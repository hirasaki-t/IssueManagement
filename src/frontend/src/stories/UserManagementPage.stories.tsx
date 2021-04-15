import { Meta, Story } from "@storybook/react/types-6-0";
import UserManagementPage from "../pages/UserManagementPage";

export default {
    title: "pages/UserManagementPage",
    components: UserManagementPage,
} as Meta;

const Template: Story = () => <UserManagementPage />;

export const Default = Template.bind({});