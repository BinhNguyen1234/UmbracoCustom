import { INavBarData } from "../navbar/navbar.type";

export interface IHeaderData {
    routes: INavBarData[],
    color: string
}
export interface IHeader extends IHeaderData{

}