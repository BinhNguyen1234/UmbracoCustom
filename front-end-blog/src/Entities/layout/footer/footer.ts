import { IFooterEntity, IFooterData } from "./footer.type";
import { ILinkEntity } from "./link/link.type";

class FooterEntity implements IFooterEntity {
    link: ILinkEntity[];
    style: { color: { backGround: string; font: string } };
    license: string;
    constructor(data: IFooterData) {
        this.link = data.link
        this.style = data.style
        this.license = data.license
    }
}
export default FooterEntity;
