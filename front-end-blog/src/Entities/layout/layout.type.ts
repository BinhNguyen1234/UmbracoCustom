import { IHeaderEntity } from "./header/header.type";
import { IFooterEntity } from "./footer/footer.type";
export interface ILayoutEntity {
    header: IHeaderEntity,
    footer: IFooterEntity
}
export interface ILayoutData extends ILayoutEntity {}