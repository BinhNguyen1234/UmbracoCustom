import { INavBarData } from "./navbar/navbar.type";

export interface IHeaderData {
    routes: INavBarData[],
    style: {
        color: {
            backGround: string,
            font: string
        }
    }
}
export interface IHeader extends IHeaderData{

}