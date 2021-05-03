namespace Model
{
    public enum ProjectStatuses
    {
        /// <summary>未着手</summary>
        NotStarted = 1,

        /// <summary>要求分析</summary>
        RequestAnalysis,

        /// <summary>要件定義</summary>
        RequestDefinition,

        /// <summary>基本設計</summary>
        BasicDesign,

        /// <summary>詳細設計</summary>
        DetailDesign,

        /// <summary>開発</summary>
        Development,

        /// <summary>内部テスト</summary>
        InnerTest,

        /// <summary>ユーザーテスト</summary>
        UserTest,

        /// <summary>リリース準備</summary>
        ReleasePreparation,

        /// <summary>リリース</summary>
        Release,
    }
}