import "./globals.css";
import { getNavBarItem } from "@/Service/Ui.service";
import Header from "@/Components/Header/Header.view";
import NavBarMenu from "@/Components/Header/NavBar/NavBarMenu.view";

export const dynamic = "force-dynamic"
export default async function RootLayout({
    children,
}: {
    children: React.ReactNode;
}) {
    const ListNavItem = await getNavBarItem()
    return (
        <html lang="en">
            <body className={ " dark"}>
                <Header>
                    <NavBarMenu items={ListNavItem}></NavBarMenu>
                </Header>
                {children}
            </body>
        </html>
    );
}
