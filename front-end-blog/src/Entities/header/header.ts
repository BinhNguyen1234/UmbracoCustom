import { INavBarData } from "./navbar/navbar.type";
import { IHeader } from "./header.type";

export default class Header implements IHeader {
    constructor(data: IHeader) {
        this.routes = data.routes
        this.style = data.style
        this.logo = data.logo
    }
    routes: INavBarData[];
    style: { color: { backGround: string; font: string; }; };
    logo: string
}