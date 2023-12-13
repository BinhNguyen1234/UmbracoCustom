
import HttpClientAdapter from "@/lib/ApiAdapter";
export default async function getRoutesConfig(){
    const api = new HttpClientAdapter()
    const result = await api.get(
        { url:"http://localhost:5180/api/mockup/get/routes" }
    );
    return result.data
}