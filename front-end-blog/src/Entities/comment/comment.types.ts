export interface ICommentData {
    readonly author: string;
    readonly content: string;
    readonly id: unknown;
    readonly createTime: Date | string;
    readonly reply: ICommentData[]
}

export interface IComment extends ICommentData {

}