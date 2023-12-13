import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse, CreateAxiosDefaults } from "axios";

class HttpClientAdapter {
    core: AxiosInstance;
    constructor(config: CreateAxiosDefaults = {}) {
        this.core = axios.create(config);
    }
    async #makeRequest(method: string, config: AdapterRequestConfig){
        try {
            const { status, statusText, data }: AxiosResponse = await (<any> this.core)[method](config.url, config);
            return { status: status, message: statusText, data: data, isError: false };
        } catch (e) {
            const errorDetail = (<any>e)?.response
            return { status: errorDetail?.status, message: errorDetail?.message, data: errorDetail?.data, isError: true }
        }
    }
    async get(config: AdapterRequestConfig) {
        await this.#makeRequest("get", config)
    }
    async post(config: AdapterRequestConfig) {
        await this.#makeRequest("post", config)
    }
    async delete(config: AdapterRequestConfig) {
        await this.#makeRequest("delete", config)
    }
    async put(config: AdapterRequestConfig) {
        await this.#makeRequest("put", config)
    }
    async request(config: AdapterRequestConfig) {
        await this.#makeRequest(config.method || "get", config)
    }
}
interface AdapterRequestConfig extends AxiosRequestConfig {
    url: string
}
export default HttpClientAdapter
