
import { INavBarEntity } from "@/Entities/layout"
import { LayoutApi } from "@/apis/server/LayoutApi"

interface IParams {
    route: string
}
export const dynamic = "force-dynamic"
export const dynamicParams = false 
export async function generateStaticParams() {
    const items = await LayoutApi.getRoutesConfig()
    return _.map<INavBarEntity, IParams>(items, (value)=>{
        const route = value.url.replace(/^\//, "")
        return { route }
    })
} 
export default function Route(){
    return <>
    </>
}

