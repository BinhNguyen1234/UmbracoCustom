import config from "@config";
import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse, CreateAxiosDefaults } from "axios";

class HttpClientAdapter {
    requestFactory: AxiosInstance;
    constructor(config: CreateAxiosDefaults = {}) {
        this.requestFactory = axios.create(config);
    }
    async #makeRequest<T>(method: string, config: AdapterRequestConfig){
        try {
            const { status, statusText, data }: AxiosResponse = await (<any> this.requestFactory)[method](config.url, config);
            return { status: status, message: statusText, data: data as T, isError: false };
        } catch (e) {
            throw e
        }
    }
    async get<T>(config: AdapterRequestConfig) {
        return await this.#makeRequest<T>("get", config)
    }
    async post(config: AdapterRequestConfig) {
        return await this.#makeRequest("post", config)
    }
    async delete(config: AdapterRequestConfig) {
        return await this.#makeRequest("delete", config)
    }
    async put(config: AdapterRequestConfig) {
        return await this.#makeRequest("put", config)
    }
    async request(config: AdapterRequestConfig) {
        return await this.#makeRequest(config.method || "get", config)
    }
}
interface AdapterRequestConfig extends AxiosRequestConfig {
    url: string
}
export const httpClientAdapter = new HttpClientAdapter({ baseURL: config.BaseUrl })
