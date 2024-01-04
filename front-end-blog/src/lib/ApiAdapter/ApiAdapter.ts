// import config from "@config";
import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse, CreateAxiosDefaults } from "axios";
import { IApiAdapter, IApiAdapterReturn } from "./ApiAdapter.type";

export class HttpClientAdapter implements IApiAdapter {
    #requestFactory: AxiosInstance;
    constructor(config: CreateAxiosDefaults = {}) {
        this.#requestFactory = axios.create(config);
    }
    async #makeRequest<T>(method: string, config: AdapterRequestConfig){
        try {
            const { status, statusText, data }: AxiosResponse = await (<any> this.#requestFactory)[method](config.url, config);
            return <IApiAdapterReturn<T>>{ status: status, message: statusText, data: <T>data, isError: false };
        } catch (e) {
            throw e
        }
    }
    async get<T>(config: AdapterRequestConfig) {
        return await this.#makeRequest<T>("get", config)
    }
    async post<T>(config: AdapterRequestConfig) {
        return await this.#makeRequest<T>("post", config)
    }
    async update<T>(config: AdapterRequestConfig) {
        return await this.#makeRequest<T>("post", config)
    }
    async delete<T>(config: AdapterRequestConfig) {
        return await this.#makeRequest<T>("delete", config)
    }
    async put<T>(config: AdapterRequestConfig) {
        return await this.#makeRequest<T>("put", config)
    }
    async request<T>(config: AdapterRequestConfig) {
        return await this.#makeRequest<T>(config.method || "get", config)
    }
}
export interface AdapterRequestConfig extends AxiosRequestConfig {
    url: string
}

