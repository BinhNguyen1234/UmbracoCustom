import { IComment, ICommentData } from "./comment.types";

export class Comment implements IComment {
    author!: string;
    content!: string;
    id: unknown;
    createTime!: string | Date;
    reply!: ICommentData[];
    constructor(data: ICommentData) {
        this.author = data.author;
        this.content = data.content;
        this.id = data.id;
        this.reply = data.reply
    }
}
