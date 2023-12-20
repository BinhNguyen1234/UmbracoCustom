import { IFooterEntity } from "@/Entities/layout/footer/footer.type";
import LinkFooter from "./link/link.view";
import LinkEntity from "@/Entities/layout/footer/link/link";
export default function Footer({ footer }: { footer: IFooterEntity }){
    const { link, license } = footer
    function LinkFooterItem(){
        return _.map<LinkEntity, JSX.Element>(link, (i)=>{
            return <li>
                <LinkFooter link={i}></LinkFooter>
            </li>
        })
    } 
    return <>
        <footer className="!useAutoDarkTheme py-[30px] ">
            <ul className="flex gap-x-[14px] text-lg">
                <li>{license}</li>
                <LinkFooterItem></LinkFooterItem>
            </ul>
        </footer>
    </>
}
