"use server";
import "./NavBarItem.component";
import NavBarItem from "./NavBarItem.component";
import DarkModeToggleBtn from "./DarkModeToggleBtn";
import { TRoutes } from "@/ModelData/Route.model";
import getRoutesConfig from "@/apis/server/getRoutes";

export default async function NavBarMenu() {
    const items = await getRoutesConfig()
    function ListNavBarItem() {
        return _.map<TRoutes, JSX.Element>(items, (value, index) => {
            return (
                <NavBarItem
                    key={index}
                    name={value.name}
                    url={value.url}
                ></NavBarItem>
            );
        })
    } 
    return (
        <>
            <ul className="md:flex md:justify-end md:gap-x-3.5 md:leading-6 md:text-xl">
                <ListNavBarItem></ListNavBarItem>
                <li className="w-[55px] flex justify-center items-center">
                    <DarkModeToggleBtn></DarkModeToggleBtn>
                </li>
            </ul>
        </>
    );
}
