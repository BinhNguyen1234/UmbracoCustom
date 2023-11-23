"use client";
import "./NavBarItem";
import map from "lodash/map";
import { ConfigForItem } from "@/Constant/Routing.constant";
import NavBarItem from "./NavBarItem";

import DarkModeButton from "../../../UIComponent/DarkModeBtn";
interface PropsNavBarMenu {
    RoutingConstant: Array<ConfigForItem>;
}
let style = "md:flex md:justify-end md:gap-x-3.5 md:leading-6 md:text-xl";

export default function NavBarMenu({ ...props }: PropsNavBarMenu) {
    return (
        <>
            <ul className={style}>
                {map<ConfigForItem, JSX.Element>(
                    props.RoutingConstant,
                    (value) => {
                        return (
                            <NavBarItem
                                key={value.textDisplay}
                                text={value.textDisplay}
                                href={value.routingHref}
                            ></NavBarItem>
                        );
                    }
                )}
                <li className="w-[55px] flex justify-center items-center"><DarkModeButton></DarkModeButton></li>
            </ul>
        </>
    );
}
