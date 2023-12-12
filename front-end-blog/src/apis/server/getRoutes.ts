import { TRoutes } from "@/ModelData/Route.model";
import axios from "axios";

export default async function getRoutesConfig(){
    const result = await axios.get<[TRoutes]>(
        "http://localhost:5180/api/mockup/get/routes"
    );
    return result.data
}