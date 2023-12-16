import { NavBar } from "../navbar/navbar";
import { IHeader } from "./header.type";

export default class Header implements IHeader {
    routes: NavBar[];
    color: string;
    constructor(data: IHeader) {
        this.routes = data.routes
        this.color = data.color
    }
}