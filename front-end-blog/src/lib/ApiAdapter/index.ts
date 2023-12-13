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
            throw e
        }
    }
    async get(config: AdapterRequestConfig) {
        return await this.#makeRequest("get", config)
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
export default HttpClientAdapter
