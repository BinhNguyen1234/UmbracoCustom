import "./globals.css";
import StoreProvider from "./store";
import Header from "@/Components/Header";
export const dynamic = "force-dynamic"
export default function RootLayout({
    children,
}: {
    children: React.ReactNode;
}) {
    return (
        <StoreProvider>
            <html lang="en">
                <body>
                    <Header></Header>
                    {children}
                </body>
            </html>
        </StoreProvider>

    );
}
