import { httpClientAdapter } from "@/lib/ApiAdapter";
import { INavBarData } from "@/Entities/header/navbar/navbar.type";
import { IHeader, IHeaderData } from "@/Entities/header/header.type";
import Header from "@/Entities/header/header";
import { NavBar } from "@/Entities/header/navbar/navbar";
export const LayoutApi = {
    getHeaderConfig: async function (): Promise<IHeader> {
        const { data } = await httpClientAdapter.get<IHeaderData>({
            url: "/api/mockup/get/header",
        });
        return new Header(data);
    },
    getRoutesConfig: async function (): Promise<INavBarData[]> {
        const { data } = await httpClientAdapter.get<INavBarData[]>({
            url: "/api/mockup/get/routes",
        });
        return data.map((d)=>{
            return new NavBar(d)
        })
    },
};
