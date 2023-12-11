export interface IPostData {
    readonly id: unknown,
    readonly title: string,
    readonly content: string,
    readonly author: string
    readonly tag: string,
    readonly createDate: Date | string
}
export interface IPost extends IPostData {
    readonly comments: unknown[]
}