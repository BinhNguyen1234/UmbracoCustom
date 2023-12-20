/* eslint-disable @next/next/no-img-element */
import { IHeaderEntity } from "@/Entities/layout";
interface HeaderViewProps {
    children: JSX.Element;
    headerStyle: IHeaderEntity["style"];
    headerLogo: string
}
export default function HeaderView({
    children,
    headerStyle,
    headerLogo
}: HeaderViewProps): JSX.Element {
    return (
        <>
            <header
                style={{
                    backgroundColor: headerStyle.color.backGround,
                    color: headerStyle.color.font,
                }}
                className="py-[30px] !useAutoDarkTheme"
            >
                <div className="flex h-[60px] justify-between items-center px-[7rem]">
                    <div className="basis-1/5 h-full">
                        <img
                            className="max-h-[100%] max-w-[100%]"
                            alt="logo"
                            src={headerLogo}
                        ></img>
                    </div>
                    {children}
                </div>
            </header>
        </>
    );
}
