import { LayoutApi } from "@/apis/server/getRoutes";
import HeaderView from "./Header.view";
import NavBar from "./NavBar";

export default async function Header() {
    const { routes, style, logo } = await LayoutApi.getHeaderConfig()
    return <>
        <HeaderView headerLogo={logo} headerStyle={style} 
            NavBar={<NavBar items={routes}></NavBar>}>
            
        </HeaderView></>
}