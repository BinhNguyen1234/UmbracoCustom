import { AdapterRequestConfig } from "./ApiAdapter";

export interface IApiAdapter {
    get: <T>(config: AdapterRequestConfig)=> Promise<IApiAdapterReturn<T>>;
    post: <T>(config: AdapterRequestConfig)=> Promise<IApiAdapterReturn<T>>;
    put: <T>(config: AdapterRequestConfig)=> Promise<IApiAdapterReturn<T>>;
    update: <T>(config: AdapterRequestConfig)=> Promise<IApiAdapterReturn<T>>;
    delete: <T>(config: AdapterRequestConfig)=> Promise<IApiAdapterReturn<T>>;
    request: <T>(config: AdapterRequestConfig)=> Promise<IApiAdapterReturn<T>>;
}
export interface IApiAdapterReturn<T> { 
    status: number, 
    message: string, 
    data: T,
    isError: boolean,
    headers: unknown
};