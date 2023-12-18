import config from "@config"
import { httpClientAdapter } from "@/lib/ApiAdapter";
import { INavBar } from "@/Entities/header/navbar/navbar.type";
import { IHeader } from "@/Entities/header/header.type";
export async function getRoutesConfig(): Promise<INavBar[]>{

    const result = await httpClientAdapter.get(
        { url: config.apiUrl + "/api/mockup/get/routes" }
    );
    return result.data
}
export async function getHeaderConfig(): Promise<IHeader[]> {
    const result = await httpClientAdapter.get(
        { url: config.apiUrl + "/api/mockup/get/header" }
    );
    return result.data
}