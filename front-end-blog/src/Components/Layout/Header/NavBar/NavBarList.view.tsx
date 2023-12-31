
import "./NavBarItem.view";
import NavBarItem from "./NavBarItem.view";
import DarkModeToggleBtn from "./DarkModeToggleBtn.control";
import { INavBarEntity } from "@/Entities/layout";

export default function NavBar({ items }: { items: INavBarEntity[] }) {
    function ListNavBarItem() {
        return _.map<INavBarEntity, JSX.Element>(items, (value, index) => {
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
            <ul className="md:flex md:justify-around md:justify-end md:gap-x-3.5 md:leading-6 md:text-xl">
                <ListNavBarItem></ListNavBarItem>
                <li className="w-[55px] flex justify-center items-center">
                    <DarkModeToggleBtn></DarkModeToggleBtn>
                </li>
            </ul>
        </>
    );
}
