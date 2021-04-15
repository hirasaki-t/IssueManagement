import { Meta, Story } from "@storybook/react/types-6-0";
import ProfileSettingPage from "../pages/ProfileSettingPage";

export default {
    title: "pages/ProfileSettingPage",
    components: ProfileSettingPage,
} as Meta;

const Template: Story = () => <ProfileSettingPage />;

export const Default = Template.bind({});