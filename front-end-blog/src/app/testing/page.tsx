import { Metadata } from "next"
import NavBarMenu from "@/Components/Header/NavBar/NavBarMenu.container"
export const metadata: Metadata = {
    title: "this is for testing individual comopoent",
    description: "this is for testing individual comopoent",
}
export default function Testing(){
    return (<>
        <NavBarMenu></NavBarMenu>
    </>)
}