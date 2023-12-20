import "./globals.css";
import StoreProvider from "./store";
import Header from "@/Components/Layout/Header";
import Footer from "@/Components/Layout/Footer";
import { LayoutApi } from "@/apis/server/LayoutApi";
export const dynamic = "force-dynamic"
export default async function RootLayout({
    children,
}: {
    children: React.ReactNode;
}) {
    const { header, footer } = await LayoutApi.getLayoutConfig()
    return (
        <StoreProvider>
            <html lang="en">
                <body>
                    <Header header={header}></Header>
                    {children}
                    <Footer footer={footer}></Footer>
                </body>
            </html>
        </StoreProvider>
    );
}
