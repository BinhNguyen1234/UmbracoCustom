import { INavBarEntity, INavBarData } from "./navbar.type";
export default class NavBarEntity implements INavBarEntity {
    url: string;
    name: string;
    constructor (data: INavBarData){
        this.url = data.url
        this.name = data.name
    }
}