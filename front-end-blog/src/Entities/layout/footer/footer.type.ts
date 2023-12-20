import { ILinkData, ILinkEntity } from "./link/link.type";

export interface IFooterEntity {
    link: ILinkEntity[];
    style: { color: { backGround: string; font: string } };
    license: string
}
export interface IFooterData extends Omit<IFooterEntity, "link"> {
    link: ILinkData[];
}
