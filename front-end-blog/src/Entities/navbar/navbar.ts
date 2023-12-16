import { INavBar, INavBarData } from "./navbar.type";
export class NavBar implements INavBar {
    url: string;
    name: string;
    constructor (data: INavBarData){
        this.url = data.url
        this.name = data.name
    }
}