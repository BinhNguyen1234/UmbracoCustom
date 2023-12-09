"use server";
import "./NavBarItem";
import { ConfigForItem } from "@/Constant/Routing.constant";
import NavBarItem from "./NavBarItem";
import DarkModeButton from "../../../UIComponent/DarkModeBtn";
import axios from "axios";
import { TRoutes } from "@/ModelData/Route.model";
import getRoutesConfig from "@/apis/server/getRoutes";
interface PropsNavBarMenu {
    RoutingConstant: Array<ConfigForItem>;
}

export default async function NavBarMenu({ ...props }: PropsNavBarMenu) {
    const items = await getRoutesConfig()
    return (
        <>
            <ul className="md:flex md:justify-end md:gap-x-3.5 md:leading-6 md:text-xl">
                {_.map<TRoutes, JSX.Element>(items.data, (value, index) => {
                    return (
                        <NavBarItem
                            key={index}
                            name={value.name}
                            url={value.url}
                        ></NavBarItem>
                    );
                })}
                <li className="w-[55px] flex justify-center items-center">
                    <DarkModeButton></DarkModeButton>
                </li>
            </ul>
        </>
    );
}
