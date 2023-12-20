
import HeaderView from "./Header.view";
import NavBar from "./NavBar/NavBarList.view";
import { IHeaderEntity } from "@/Entities/layout";

export default function Header({ header }: { header: IHeaderEntity }) {
    const { routes, style, logo } = header
    return <>
        <HeaderView headerLogo={logo} headerStyle={style}>
            <NavBar items={routes}></NavBar>
        </HeaderView></>
}