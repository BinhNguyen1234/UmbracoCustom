'use client'
import "./NavBarItem"
import map from "lodash/map"
import { ConfigForItem } from "@/Constant/Routing.constant"
import NavBarItem from "./NavBarItem"
import {  useState } from "react"
interface PropsNavBarMenu {
    RoutingConstant: Array<ConfigForItem>
}


export default function NavBarMenu({...props}:PropsNavBarMenu){
    const [num, setNum] = useState(1);
    console.log("rerender")
    return (<>
        <ul>
            {/* {map<ConfigForItem, JSX.Element>(props.RoutingConstant, (value)=>{
                return (
                  <NavBarItem
                    key={value.textDisplay}
                    text={value.textDisplay}
                    href={value.routingHref}
                  ></NavBarItem>
                );
            })} */}
            {/* <NavBarItem key={"props.textDisplay"}
                    text={"value.textDisplay"}
                    href={"value.routingHref"}/> */}
            {
                NavBarItem({text:"fff",href:"ffff"})
            }
        </ul>
        <button onClick={e=>{setNum(state => state+=1)}}>Click</button>
    </>)
}