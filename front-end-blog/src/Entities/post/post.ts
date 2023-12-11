import { IPost, IPostData } from "./post.types";

export class Post implements IPost {
    comments!: unknown[];
    id: unknown;
    title!: string;
    content!: string;
    author!: string;
    tag!: string;
    createDate!: string | Date;
    constructor(data: IPostData){
        this.content = data.content
        this.author = data.author
        this.tag = data.tag
        this.createDate = data.createDate
        this.title = data.title
    }
}