using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.DB.DataService;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>サインインコントローラー</summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SignInController : ControllerBase
    {
        /// <summary>データサービス</summary>
        private readonly IDataService dataService;

        /// <summary>ロガー</summary>
        private readonly ILogger<SignInController> logger;

        /// <summary>コンストラクタ</summary>
        /// <param name="dataService">データサービス</param>
        /// <param name="logger">ロガー</param>
        public SignInController(IDataService dataService, ILogger<SignInController> logger)
        {
            this.dataService = dataService;
            this.logger = logger;
        }

        /// <summary>サインイン試行する</summary>
        /// <param name="signIn">サインイン情報</param>
        /// <returns>サインイン結果</returns>
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> TrySignIn(SignIn signIn)
        {
            if (!await dataService.CanSignInAsync(signIn))
            {
                logger.LogWarning("サインイン試行失敗", CreateLogParameters(signIn));
                return BadRequest();
            }
            logger.LogWarning("サインイン試行成功", CreateLogParameters(signIn));

            var claimsPrincipal = new ClaimsPrincipal(
                new ClaimsIdentity(
                    new[] { new Claim(ClaimTypes.NameIdentifier, signIn.SignInID) },
                    CookieAuthenticationDefaults.AuthenticationScheme));
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
            return Ok();

            static IEnumerable<(string, string)> CreateLogParameters(SignIn signIn) =>
                new[] { ("サインインID", signIn.SignInID) };
        }
    }
}