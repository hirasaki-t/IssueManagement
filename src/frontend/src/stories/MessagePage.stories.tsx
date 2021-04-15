import { Meta, Story } from "@storybook/react/types-6-0";
import MessagePage from "../pages/MessagePage";

export default {
    title: "pages/MessagePage",
    components: MessagePage,
} as Meta;

const Template: Story = () => <MessagePage />;

export const Default = Template.bind({});