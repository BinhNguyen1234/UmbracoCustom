import "./NavBarItem"
import map from "lodash/map"
import { ConfigForItem } from "@/Constant/Routing.constant"
import NavBarItem from "./NavBarItem"
interface PropsNavBarMenu {
    RoutingConstant: Array<ConfigForItem>
}


export default function NavBarMenu({...props}:PropsNavBarMenu){
    
    return (<>
        <ul>
            {map<ConfigForItem, JSX.Element>(props.RoutingConstant, (value)=>{
                return <NavBarItem text={value.textDisplay} href={value.routingHref}></NavBarItem>
            })}
        </ul>
    </>)
}