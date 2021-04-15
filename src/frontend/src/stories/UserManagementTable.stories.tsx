import { Meta, Story } from "@storybook/react/types-6-0";
import UserManagementTable from "../components/UserManagementTable";

export default {
    title: "components/UserManagementTable",
    components: UserManagementTable,
} as Meta;

const Template: Story = () => <UserManagementTable />;

export const Default = Template.bind({});