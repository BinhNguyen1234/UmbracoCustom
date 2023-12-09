import { TRoutes } from "@/ModelData/Route.model";
import getRoutesConfig from "@/apis/server/getRoutes"

interface IParams {
    route: string
}
export async function generateStaticParams() {
    const items = await getRoutesConfig()
    return _.map<TRoutes,IParams>(items,(value,index)=>{
        const route = value.url.replace(/^\//,"")
        return {route}
    })
} 
export default function Route({params}:{params:{route: string}}){
    return <>
        <div>
            {params.route}
        </div>
    </>
}

export const dynamicParams = false 