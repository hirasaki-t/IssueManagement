/** 案件 */
export interface Project {
    /** ID */
    id: number;

    /** 案件ステータス */
    status: number;

    /** 案件名 */
    name: string;

    /** 案件詳細 */
    details: string;

    /** 作成日付 */
    create: Date;
}