import { Metadata } from "next"
import { RoutingNavBarConstant } from "@/Constant/Routing.constant"
import NavBarMenu from "@/Components/Header/NavBar/NavBarMenu"
export const metadata: Metadata = {
    title: "this is for testing individual comopoent",
    description: "this is for testing individual comopoent",
}
export default function Testing(){
    return (<>
        <NavBarMenu RoutingConstant={RoutingNavBarConstant}></NavBarMenu>
    </>)
}