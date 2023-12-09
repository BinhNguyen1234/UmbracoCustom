import { TRoutes } from "@/ModelData/Route.model";
import axios from "axios";

export default async function getRoutesConfig(){
    return axios.get<[TRoutes]>(
        "https://raw.githubusercontent.com/BinhNguyen1234/api/master/routes.json"
    );
}