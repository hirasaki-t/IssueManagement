using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;

namespace WebApp
{
    /// <summary>設定クラス</summary>
    /// <remarks>シングルトン</remarks>
    [DataContract]
    public class Config
    {
        /// <summary>AppDataフォルダパス</summary>
        private static readonly string APP_DATA_DIRECTORY = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AppData");

        /// <summary>コンフィグファイルのパス</summary>
        private static readonly string CONFIG_FILE_PATH = Path.Combine(APP_DATA_DIRECTORY, "config.json");

        /// <summary>デバッグ用コンフィグファイルのパス</summary>
        private static readonly string CONFIG_DEBUG_FILE_PATH = Path.Combine(APP_DATA_DIRECTORY, "config_debug.json");

        /// <summary>ツール名</summary>
        [DataMember]
        public string ToolName { get; set; } = string.Empty;

        /// <summary>接続文字列</summary>
        [DataMember]
        public string ConnectionStrings { get; set; } = string.Empty;

        /// <summary>ベースURL</summary>
        [DataMember]
        public string BaseURL { get; set; } = string.Empty;

        /// <summary>データストアの接続文字列</summary>
        public string DataStoreConnectionString { get; set; } = string.Empty;

        /// <summary>設定情報を取得する</summary>
        public static Config GetConfig()
        {
            var path = CONFIG_FILE_PATH;
#if DEBUG
            path = CONFIG_DEBUG_FILE_PATH;
#endif
            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Config>(json);
        }
    }
}