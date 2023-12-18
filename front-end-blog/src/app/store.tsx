"use client"
import { configureStore } from "@reduxjs/toolkit"
import { ReactElement, useRef } from "react"
import { Provider } from "react-redux"
const makeStore = () => configureStore({
    reducer: {}
})
export default function StoreProvider({ children }: { children: ReactElement }){
    const storeRef = useRef< ReturnType<typeof makeStore> | null>(null)
    if (!storeRef.current) {
        storeRef.current = configureStore({
            reducer: {}
        })
    }
    return <Provider store={storeRef.current}>{children}</Provider>
}