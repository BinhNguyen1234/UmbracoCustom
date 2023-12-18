import { getRoutesConfig } from "@/apis/server/getRoutes";
import HeaderView from "./Header.view";
import NavBarMenu from "./NavBar/NavBarMenu.view";

export default async function Header() {
    const ListNavItem = await getRoutesConfig()
    return <>
        <HeaderView>
            <NavBarMenu items={ListNavItem}></NavBarMenu>
        </HeaderView></>
}