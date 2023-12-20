import { IHeaderEntity } from ".";
import { IFooterEntity } from "./footer/footer.type";
import { ILayoutData, ILayoutEntity } from "./layout.type";
export default class LayoutEntity implements ILayoutEntity {
    header: IHeaderEntity;
    footer: IFooterEntity;
    constructor(data: ILayoutData){
        this.footer = data.footer
        this.header = data.header
    }
    
}