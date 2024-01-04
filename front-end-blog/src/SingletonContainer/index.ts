import { HttpClientAdapter } from "@/lib/ApiAdapter"

const SingletonHttpClientAdapter = (()=>{
    let instance: HttpClientAdapter;
    function createInstance() {
        const object = new HttpClientAdapter({ baseURL: process.env.API_SERVICE });
        return object;
    }

    return {
        getInstance: function () {
            if (!instance) {
                instance = createInstance();
            }
            return instance;
        }
    }
})()
export default SingletonHttpClientAdapter.getInstance()