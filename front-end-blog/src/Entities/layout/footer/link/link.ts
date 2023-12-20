
import { ILinkData, ILinkEntity } from "./link.type";

class LinkEntity implements ILinkEntity {
    content: string;
    href: string;
    constructor (data: ILinkData){
        this.content = data.content
        this.href = data.href
    }
}
export default LinkEntity