import { INavBarData } from "./navbar/navbar.type";

export interface IHeaderEntity {
    routes: INavBarData[],
    style: {
        color: {
            backGround: string,
            font: string
        }
    },
    logo: string
}
export interface IHeaderData extends IHeaderEntity{

}