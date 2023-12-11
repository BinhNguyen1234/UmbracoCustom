import { Inter } from "next/font/google";
import "./globals.css";
import { getNavBarItem } from "@/Service/Ui.service";
import Header from "@/Components/Header/Header.view";
import NavBarMenu from "@/Components/Header/NavBar/NavBarMenu.view";
const inter = Inter({ subsets: ["latin"] });

export default async function RootLayout({
    children,
}: {
    children: React.ReactNode;
}) {
    const ListNavItem = await getNavBarItem()
    return (
        <html lang="en">
            <body className={inter.className + " dark"}>
                <Header>
                    <NavBarMenu items={ListNavItem}></NavBarMenu>
                </Header>
                {children}
            </body>
        </html>
    );
}
