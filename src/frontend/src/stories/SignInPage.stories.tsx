import { Meta, Story } from "@storybook/react/types-6-0";
import SignInPage from "../pages/SignInPage";

export default {
    title: "pages/SignInPage",
    components: SignInPage,
} as Meta;

const Template: Story = () => <SignInPage />;

export const Default = Template.bind({});