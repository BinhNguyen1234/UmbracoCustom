import getRoutesConfig from "@/apis/server/getRoutes";

export async function getNavBarItem(){
    return await getRoutesConfig()
}