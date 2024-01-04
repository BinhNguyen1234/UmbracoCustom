import httpClientAdapter from "@/SingletonContainer";
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
        return data.map((item)=>{
            return new NavBarEntity(item)
        })
    },
    getLayoutConfig: async function (): Promise<LayoutEntity> {
        const { data } = await httpClientAdapter.get<ILayoutData>({
            url: "/api/mockup/get/layout",
        });
        return new LayoutEntity(data)
    },
};
