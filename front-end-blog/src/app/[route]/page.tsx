import { TRoutes } from "@/ModelData/Route.model";
import getRoutesConfig from "@/apis/server/getRoutes"

interface IParams {
    route: string
}
// export const dynamic = 0
export const dynamicParams = false 
export async function generateStaticParams() {
    const items = await getRoutesConfig()
    return _.map<TRoutes, IParams>(items, (value)=>{
        const route = value.url.replace(/^\//, "")
        return { route }
    })
} 
export default function Route(){
    return <>
    </>
}

