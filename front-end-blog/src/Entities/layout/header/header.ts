import { INavBarEntity } from "./navbar/navbar.type";
import { IHeaderData, IHeaderEntity } from "./header.type";

export default class HeaderEntity implements IHeaderEntity {
    constructor(data: IHeaderData) {
        this.routes = data.routes
        this.style = data.style
        this.logo = data.logo
    }
    routes: INavBarEntity[];
    style: { color: { backGround: string; font: string; }; };
    logo: string
}