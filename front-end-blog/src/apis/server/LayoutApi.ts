import { httpClientAdapter } from "@/lib/ApiAdapter";
import { ILayoutData, INavBarData, LayoutEntity } from "@/Entities/layout";
import { IHeaderEntity, IHeaderData } from "@/Entities/layout";
import { HeaderEntity, NavBarEntity } from "@/Entities/layout";
export const LayoutApi = {
    getHeaderConfig: async function (): Promise<IHeaderEntity> {
        const { data } = await httpClientAdapter.get<IHeaderData>({
            url: "/api/mockup/get/header",
        });
        return new HeaderEntity(data);
    },
    getRoutesConfig: async function (): Promise<NavBarEntity[]> {
        const { data } = await httpClientAdapter.get<INavBarData[]>({
            url: "/api/mockup/get/routes",
        });
        return data.map((d)=>{
            return new NavBarEntity(d)
        })
    },
    getLayoutConfig: async function (): Promise<LayoutEntity> {
        const { data } = await httpClientAdapter.get<ILayoutData>({
            url: "/api/mockup/get/layout",
        });
        return new LayoutEntity(data)
    },
};
