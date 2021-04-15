import { Meta, Story } from "@storybook/react/types-6-0";
import SystemSettingPage from "../pages/SystemSettingPage";

export default {
    title: "pages/SystemSettingPage",
    components: SystemSettingPage,
} as Meta;

const Template: Story = () => <SystemSettingPage />;

export const Default = Template.bind({});